using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CarrierWebApi.Models
{
    public class VesselRegistration
    {
        [Key]
        public long VesselId {  get; set; }
        public int? VesselType { get; set; }
        public string? ShipIdentificationNo { get; set; }
        public DateTime? Registrationdate { get; set; }
        public string? NameofShip { get; set; }
        public int? NationalityofShip { get; set; }
        public int? FlagStateofShip {  get; set; }
        public string? IMONo {  get; set; }
        public string? CallSignNo { get; set; }
        public string? PortofRegistration {  get; set; }
        public DateTime? CertificateRegistrationDate {  get; set; }
        public decimal? GrossRegistrationTons {  get; set; }
        public decimal? DeadWeight {  get; set; }
        public decimal? DisplacementWeight {  get; set; }
        public string? PandIclub {  get; set; }
        public decimal? Beam {  get; set; }
        public decimal? StandardDraught { get; set; }
        public decimal? VesselCapacity { get; set; }
        public int? AreaofOperation { get; set; }
        public string? YearBuilt {  get; set; }
        public int? VesselTrade { get; set; }
        public int? VesselTerm { get; set; }
        public int? CargoType {  get; set; }
        public int? PositionofBridge { get; set; }
        public int? TypeofHull {  get; set; }
        public string? ApplicantRemarks {  get; set; }
        public string? StateName {  get; set; }
    }
}
