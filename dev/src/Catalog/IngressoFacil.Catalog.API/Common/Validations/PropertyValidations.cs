namespace IngressoFacil.Catalog.API.Common.Validations {
    public static class PropertyValidations {
        public static void Normalize(ref string property) {
            property = property.Trim();
        }
        public static bool IsBlank(string property) {
            return string.IsNullOrEmpty(property);
        }
        public static bool HasMinLength(string property, int minLength) {
            return property.Length >= minLength;
        }
        public static bool HasMaxLength(string property, int maxLength) {
            return property.Length <= maxLength;
        }
        public static bool IsLowerThan(int n1, int n2) {
            return n1 < n2;
        }
    }
}
