using Microsoft.AspNetCore.Mvc;
namespace bookstore.Controllers;

public abstract class BaseController : ControllerBase
{
    protected ActionResult<ResponseDto> GetResponse(object Data)
    {
        return Ok(new ResponseDto{ Status = "OK", Message="", Data = Data });
    }
    protected ActionResult<ResponseDto> GetResponse(Exception ex)
    {
        return BadRequest(new ResponseDto{ Status = "ERROR", Message= this.GetExceptionDetail(ex), Data = null });
    }

    private string GetExceptionDetail(Exception ex)
    {
        string Message = ex.Message;
        if(ex.InnerException!=null)
        {
            Message += ex.InnerException.Message;
            if(ex.InnerException.InnerException!=null) Message+= ex.InnerException.InnerException.Message;  
        }   
        return Message;
    }

}