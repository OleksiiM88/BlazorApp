namespace BlazorApp.Models.MudBlazor
{
    public class Element
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public string? ContactName { get; set; }

        public string? Sign { get; set; }

        public float? Price { get; set; }

        public bool IsActive { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }

        public DateTime Registered { get; set; }
    }
}
