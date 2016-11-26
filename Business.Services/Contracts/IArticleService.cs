﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Contracts
{
    [ServiceContract(Namespace = "http://www.chsakell.com/dotnetcorewcfproxies")]
    public interface IArticleService
    {
        [OperationContract]
        void Add(Article article);

        [OperationContract]
        void Update(Article article);

        [OperationContract]
        void Delete(Article article);

        [OperationContract]
        Article GetById(int id);

        [OperationContract]
        Article[] GetAll();
    }
}
