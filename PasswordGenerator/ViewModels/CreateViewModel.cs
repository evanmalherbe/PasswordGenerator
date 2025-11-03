namespace PasswordGenerator.ViewModels
{
	public class CreateViewModel
	{
		public string? PasswordLength { get; set; }
		public bool SpecialChars { get; set; }
		public bool UpperCase { get; set; }
		public bool LowerCase { get; set; }
		public bool Numbers { get; set; }
		public string? NewPassword { get; set; }
	}
}
