using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDokumentStavkiDetailsInfo
{
    public int Id { get; set; }

    public int TblDokumentId { get; set; }

    public int TblDokumentStavkiId { get; set; }

    public string? NotesText { get; set; }

    public string? NotesBroj { get; set; }

    public int? NotesId { get; set; }

    public int? NotesRef { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
