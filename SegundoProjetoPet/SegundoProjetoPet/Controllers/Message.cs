namespace SegundoProjetoPet.Controllers
{
    public class Message
    {
        public uint Code { get; set; }
        public string Text { get; set; }

        public Message(uint code, string text)
        {
            this.Code = code;
            this.Text = text;
        }
    }
}