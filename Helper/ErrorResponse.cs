using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helper
{
  public class ErrorResponse
  {
    public bool? Success { get; set; } = false;
    public string? Message { get; set; }
  }
}
//status, message, data