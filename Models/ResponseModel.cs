using System;
using self_blog.Models.Enum;

namespace self_blog.Models
{
	public class ResponseModel
	{
		public ResponseModel()
		{
			this.Status = ResponseStatusEnum.Failed;
		}

		public ResponseStatusEnum Status { get; set; }

		public string Message { get; set; }

        public ResponseModel Ok(string? message = "")
		{
			this.Status = ResponseStatusEnum.Success;
			if(message != null) this.Message = message;

			return this;
		}

        internal ResponseModel Failed(string message)
		{
			this.Message = message;
			return this;
		}
    }
}

