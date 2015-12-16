namespace CodeCracker
{
    public static class HelpLink
    {
        private static readonly System.Collections.Generic.List<string> availableLocalizationCultureNames = new System.Collections.Generic.List<string> { "ru" };
        public static string ForDiagnostic(DiagnosticId diagnosticId)
        {
            var name = System.Globalization.CultureInfo.CurrentCulture.Parent.Name;
            if (availableLocalizationCultureNames.Contains(name))
            {
                return $"https://code-cracker.github.io/{name}/diagnostics/{diagnosticId.ToDiagnosticId()}.html";
            }
            else
            {
                return $"https://code-cracker.github.io/diagnostics/{diagnosticId.ToDiagnosticId()}.html";

            }
        }
    }
}
