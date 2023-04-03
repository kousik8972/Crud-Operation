using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Crud_Operation.CommonLayer.Model
{
    public class DeleteRecordRequest
    {
       public int Id { get; set; }

    }

    public class DeleteRecordResponse
    {
       public bool IsSuccess { get; set; }
       public string? Message { get; set; }
    }
}