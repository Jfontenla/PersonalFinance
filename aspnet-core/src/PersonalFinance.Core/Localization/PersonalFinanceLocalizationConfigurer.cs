using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PersonalFinance.Localization
{
    public static class PersonalFinanceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PersonalFinanceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PersonalFinanceLocalizationConfigurer).GetAssembly(),
                        "PersonalFinance.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
