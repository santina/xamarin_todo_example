using System;

namespace Tasky.Shared 
{
	/// <summary>
	/// Todo Item business object
	/// </summary>
	public class TodoItem 
	{
		public TodoItem ()
		{
		}

		public string Name { get; set; }
        public int ID { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }	// TODO: add this field to the user-interface 

        public string Email { get; set; }
	}
}