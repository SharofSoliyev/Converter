using AutoMapper;
using Converter.BusinnesLogic.Interfaces;
using Converter.BusinnesLogic.Mappers;
using Converter.BusinnesLogic.Models;
using Converter.Core.Entities;
using Converter.Infostructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.BusinnesLogic.Services
{
    public class CurrencyConverterService : ICurrencyConverterService
    {
       private readonly IRepository<CurrencyConverter> _repository;

        private readonly IMapper _mapper;

        public CurrencyConverterService(IRepository<CurrencyConverter> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async void AddConverterData(ConverterModel currencyModel)
        {
            currencyModel.Date = DateTime.Now.ToString();
            var result = _mapper.Map<CurrencyConverter>(currencyModel);
            await _repository.AddAsync(result);
        }

        public List<ConverterModel> ConverterModels()
        {
            var result = _repository.GetAll().ToList();
            List<ConverterModel> converterModels = _mapper.Map<List<ConverterModel>>(result);
            return converterModels;
        }
    }
}
