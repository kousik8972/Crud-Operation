using System;
using System.Threading.Tasks;
using Crud_Operation.CommonLayer.Model;
using Crud_Operation.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Operation.controllers

{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class CrudOperationController : ControllerBase
    {
        public readonly ICrudOperationSL _crudOperationSL;
        public CrudOperationController(ICrudOperationSL crudOperationSL)
        {
            _crudOperationSL = crudOperationSL;
        }
        [HttpPost]
        [Route(template: "CreateRecord")]
        public async Task<IActionResult> CreateRecord(CreateRecordRequest request)
        {
            CreateRecordResponse? response = null;
            try
            {
                response = await _crudOperationSL.CreateRecord(request);
            }
            catch (Exception ex)
            {
                if (response != null)
                {
                    response.IsSuccess = false;
                    response.Message = ex.Message;
                }
            }

            return Ok(response);

        }

        [HttpGet]
        [Route(template: "ReadRecord")]
        public async Task<IActionResult> ReadRecord()
        {
            ReadRecordResponse? response = null;
            try
            {
                response = await _crudOperationSL.ReadRecord();
            }
            catch (Exception ex)
            {

            }

            return Ok(response);
        }

        [HttpPut]
        [Route(template: "UpdateRecord")]
        public async Task<IActionResult> UpdateRecord(UpdateRecordRequest recordRequest)
        {
            UpdateRecordResponse? response = null;
            try
            {
                response = await _crudOperationSL.UpdateRecord(recordRequest);
            }
            catch (Exception ex)
            {

            }

            return Ok(response);
        }

        [HttpDelete]
        [Route(template: "DeleteeRecord")]
        public async Task<IActionResult> DeleteRecord(DeleteRecordRequest request)
        {
            DeleteRecordResponse? response = null;
            try
            {
                response = await _crudOperationSL.DeleteRecord(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }
    }
}