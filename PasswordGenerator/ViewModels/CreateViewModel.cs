namespace PasswordGenerator.ViewModels
{
	public class CreateViewModel
	{
		public int Length { get; set; }
		public bool SpecialChars { get; set; }
		public bool UpperCase { get; set; }
		public bool LowerCase { get; set; }
		public bool Numbers { get; set; }
	}
}
