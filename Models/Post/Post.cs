using System;
using self_blog.Models.Enum;

namespace self_blog.Models.Post
{
	public class Post: BaseData
	{
		public Post()
		{
			this.Status = PostStatusEnum.Private;
		}

		public int Id { get; set; }

		public string Title { get; set; }

		public string Content { get; set; }

		public PostStatusEnum Status { get; set; }
	}
}

