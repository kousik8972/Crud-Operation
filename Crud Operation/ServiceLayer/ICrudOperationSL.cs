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

namespace Crud_Operation.ServiceLayer
{
    public interface ICrudOperationSL
    {
        public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request);
        public Task<ReadRecordResponse> ReadRecord();

        public Task<UpdateRecordResponse> UpdateRecord(UpdateRecordRequest request);

        public Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest request);
    }

}