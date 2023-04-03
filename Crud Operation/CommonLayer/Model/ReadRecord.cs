using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Operation.CommonLayer.Model;
using Crud_Operation.RepositoryLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;


namespace Crud_Operation.CommonLayer.Model
{
    public class ReadRecordResponse
    {
       public bool IsSuccess { get; set; }
       public string? Message { get; set; }

       public List<ReadRecordData>? readRecordData { get; set; }
    }

    public class ReadRecordData
    {
        public string? UserName { get; set; }
        public int Age { get; set; }
    }
}