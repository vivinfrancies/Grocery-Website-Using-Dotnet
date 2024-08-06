using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Grocery08
{
   
    public class carousel
    {
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
    public class Model
    {
        public string Img { get; set; } = string.Empty;
        public string Qty { get; set; } = string.Empty;
        public string MRP { get; set; } = string.Empty;
        public string Avb { get; set; } = string.Empty;
        public string link { get; set; }=string.Empty;
    }

    public static class Extensions
    {
        public static IEnumerable<IEnumerable<T>> ChunkBy<T>(this IEnumerable<T> source, int chunkSize)
        {
            while (source.Any())
            {
                yield return source.Take(chunkSize);
                source = source.Skip(chunkSize);
            }
        }
    }
    public class Category
    {
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Heading { get; set; } = string.Empty;
    }

    public class Recipe
    {
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
    public class Reviewcard
    {
        public string Name { get; set; }
        public int Review { get; set; }
        public string Comments { get; set; }
        public string img { get; set; }


    }

    public class radiobutton
	{
		public int Radiovalue { get; set; }
		public int Radiovalue2 { get; set; }
	}
	public class Cerditcard
	{


		public string Cerditcardnumber { get; set; }

		public string expiryyear { get; set; }
		public string cvv { get; set; }
	}
	public class card
	{
        [Required]
        [StringLength(15,ErrorMessage ="The character must be less than 15")]
        [RegularExpression(@"^[A-Za-z]+$",ErrorMessage ="Only Alphbets is requried")]
		public string cardholdername { get; set; }
		public string cardnumber { get; set; }

		public string cardexpiry { get; set; }

		public string cardcvv { get; set; }
	}

	public class Search
	{
		public int expirymonth { get; set; }
		public void gote()
		{

			if (expirymonth == null)
			{
				expirymonth = 00;
			}
			else if (expirymonth.ToString().Length < 2)
			{
				expirymonth = 0 + expirymonth;
			}
			else
			{
				expirymonth = expirymonth;
			}
		}

	}
    public class Item
    {
        public int id { get; set; }
        public string ImageSrc { get; set; }
        public string Header { get; set; }
        public string categorypath { get; set; }
        public string link { get; set; }
    }

    public class categegorycards
    {

        public string path { get; set; }
        public string Header { get; set; }
        public int? amt { get; set; }

        public int? originalmrp { get; set; }
        public string SelectedQuantity { get; set; } = "1 kg";
        public string SelectedQuantity1 { get; set; } = "250g";
        public string SelectedQuantity2 { get; set; } = "1 litre";
        public double Rating { get; set; }
        public int offer { get; set; }
        public int numrate { get; set; }
    }

    public class profileform
    {
        [StringLength(15, ErrorMessage = "Length of the Name Should be less than 15 Character")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Alphabets is Requried")]
        public string Fname1 { get; set; } = "Hema";
        [StringLength(15, ErrorMessage = "Length of the Name Should be less than 15 Character")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Alphabets is Requried")]
        public string Lname1 { get; set; } = "N S";

		[StringLength(15, ErrorMessage = "Length of the city Should be less than 15 Character")]
		[RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Alphabets is Requried")]
		public string City1 { get; set; } = "Coimbatore";

		[StringLength(6, ErrorMessage = "Length of the pincode Should be less than 6 Character")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Only number is Requried")]
		public string Pincode1 { get; set; } = "641018";

		[StringLength(10, ErrorMessage = "Length of the phonenumber Should be less than 10 Character")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Only number is Requried")]
		public string Phonenumber1 { get; set; } = "64101878654";

		[StringLength(15, ErrorMessage = "Length of the State Should be less than 15 Character")]
		[RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only Alphabets is Requried")]
		public string  state1{ get; set; } = "Tamilnadu";

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter valid email")]
        public string Email1 { get; set; } = "hema@gmail.com";
        public string Address11 { get; set; } = "6/83 Airport road";
		public string Address21 { get; set; } = "cbe road";

	}
    public class search
    {
        public string name { get; set; }
        public string link { get; set; }
    }

    //Login and Signup Model 👇
    public class loginpage
    {
        //Forget Page 👇
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter the valid email address")]
        public string ForgetEmail { get; set; }
        [Required]
        public string ForgetOtp { get; set; }
        public string ForgetPass { get; set; }

        //Login Page 👇
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter the valid email address")]
        public string LoginEmail { get; set; }

        //Signup Page 👇
        [RegularExpression(@"[0-9]{10}$", ErrorMessage = "Mobile Number contains number only")]
        public string SignupMobilenumber { get; set; }

        public string SignupPassword { get; set; }
    }


}
