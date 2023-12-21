﻿using Business.Messages;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class LanguageBusinessRules
    {
        private readonly ILanguageDal _languageDal;

        public LanguageBusinessRules(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public async Task IsExistsLanguage(Guid languageId)
        {
            var result = await _languageDal.GetListAsync(
                predicate: l => l.Id == languageId
                );
            if (result == null)
            {
                throw new Exception(BusinessMessages.DataNotFound);
            }
        }
    }
}
