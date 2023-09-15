using System;
using PomeloFintech.Models.Users;

namespace PomeloFintech.Models.Cards
{
	public class GetCardsAPIResponse
	{
        public List<CreatedCard> data { get; set; } = null!;
        public MetaData meta { get; set; } = null!;
    }
}

