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
    public interface IBlogService
    {
        [OperationContract]
        void Add(Blog blog);

        [OperationContract]
        void Update(Blog blog);

        [OperationContract]
        void Delete(Blog blog);

        [OperationContract]
        Blog GetById(int id);

        Blog[] GetAll();
    }
}
