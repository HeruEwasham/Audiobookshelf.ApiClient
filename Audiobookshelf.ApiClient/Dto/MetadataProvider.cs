using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto
{
    public enum MetadataProvider
    {
        [EnumMember(Value = "google")]
        GoogleBooks,
        [EnumMember(Value = "openlibrary")]
        OpenLibrary,
        [EnumMember(Value = "itunes")]
        Itunes,
        [EnumMember(Value = "audible")]
        Audible_com,
        [EnumMember(Value = "audible.ca")]
        Audible_ca,
        [EnumMember(Value = "audible.uk")]
        Audible_co_uk,
        [EnumMember(Value = "audible.au")]
        Audible_com_au,
        [EnumMember(Value = "audible.fr")]
        Audible_fr,
        [EnumMember(Value = "audible.de")]
        Audible_de,
        [EnumMember(Value = "audible.jp")]
        Audible_co_jp,
        [EnumMember(Value = "audible.it")]
        Audible_it,
        [EnumMember(Value = "audible.in")]
        Audible_co_in,
        [EnumMember(Value = "audible.es")]
        Audible_es,
        [EnumMember(Value = "fantlab")]
        Fantlab_ru,
    }
}