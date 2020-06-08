using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTO;

namespace BLL.Services.Interfaces
{
    public interface IOperatorService
    {
        IEnumerable<Operator_DTO> GetTopics(int page);
    }
}