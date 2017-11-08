public class GetDatabaseStats
{
    public string tablename { get; set; }
    public int? row_count { get; set; }
    public string reserved { get; set; }
    public string data { get; set; }
    public string index_size { get; set; }
    public string unused { get; set; }
    public string schemaname { get; set; }
}
