public class Reservation
{
    public long id { get; set; }
    public long site { get; set; }
    public long? beid { get; set; }
    public long? cceocc { get; set; }
    public long? crecheid { get; set; }
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public string note { get; set; }
    public byte resstat { get; set; }
    public DateTime? provexp { get; set; }
    public long? relpers { get; set; }
    public DateTime datmade { get; set; }
    public string ressource { get; set; }
    public long persmake { get; set; }
    public long? cdet { get; set; }
    public long? rtmem { get; set; }
    public bool timelk { get; set; }
    public DateTime? origst { get; set; }
    public DateTime? origen { get; set; }
    public short? bookatt { get; set; }
    public short? bookgam { get; set; }
    public int? ovmaxattin { get; set; }
    public long? prevres { get; set; }
    public long? clicas { get; set; }
    public long? pkgrp { get; set; }
    public bool archived { get; set; }
    public long? table { get; set; }
    public bool? attendeesreclaimed { get; set; }
    public long? reschprev { get; set; }
    public long? reschnext { get; set; }
    public int? loggedattendees { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
