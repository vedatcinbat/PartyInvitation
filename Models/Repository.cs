namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new();

        public static IEnumerable<GuestResponse> Responses = responses;

        public static void addResponse(GuestResponse response) {
            responses.Add(response);
        }
    }
}