namespace API.Infrastructure.Shared.Shared
{
    public abstract class BaseQuery
    {
        public string Table { get; set; }
        public string InnerTable { get; set; }
        public string Query { get; set; }
        public object Parameters { get; set; }
    }
}