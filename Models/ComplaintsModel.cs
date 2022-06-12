using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComplaintsApi.Models
{
    public class Complaint
    {
        [Key]
        public long ComplaintId { get; set; }
        [JsonPropertyName("application_full_name")]
        public string ApplicationFullName { get; set; }
        [JsonPropertyName("form")]
        public int Form { get; set; }
        [JsonPropertyName("tin")]
        public int Tin { get; set; }
        [JsonPropertyName("pnfl")]
        public long PinFl{ get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("address")]         
        public int Addres { get; set; }
        [JsonPropertyName("email")]
        public int EMail { get; set; }
        [JsonPropertyName("sip_id")]
        public int SipId { get; set; }
        [JsonPropertyName("lot_nomer")]
        public int LotNomer { get; set; }
        [JsonPropertyName("indication_id")]
        public int IndicationId { get; set; }
        [JsonPropertyName("complaint_text")]
        public int ComplaintText { get; set; }
        [JsonPropertyName("ecp_code")]
        public int EcpCode { get; set; }
        [JsonPropertyName("signing_date")]
        public int SigningDate { get; set; }
        [JsonPropertyName("unique_number")]
        public int UniqueNumber { get; set; }
        [JsonPropertyName("files")]

        public File Files { get; set; }

    }
    public class File
    {
        [Key]
        public long FileId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("file")]

        public string FileContent { get; set; }//vaqtincha
    }
}
