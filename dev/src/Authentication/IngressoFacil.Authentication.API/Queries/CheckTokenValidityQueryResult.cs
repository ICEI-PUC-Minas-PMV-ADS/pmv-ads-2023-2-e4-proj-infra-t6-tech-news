namespace IngressoFacil.Authentication.API.Queries {
    public class CheckTokenValidityQueryResult {
        public bool IsValid { get; set; }
        public bool IsExpired { get; set; }
    }
}
