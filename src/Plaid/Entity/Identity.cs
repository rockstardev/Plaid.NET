using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents an account holder information.
    /// </summary>
    public class Identity
    {
        /// <summary>
        /// Gets or sets the names.
        /// </summary>
        /// <value>The names.</value>
        [JsonProperty("names")]
        public string[] Names { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        /// <value>The emails.</value>
        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>The phone numbers.</value>
        [JsonProperty("phone_numbers")]
        public Phone[] PhoneNumbers { get; set; }

        #region Structs

        /// <summary>
        /// Represents a <see cref="Identity"/> phone number.
        /// </summary>
        public struct Phone
        {
            /// <summary>
            /// Gets or sets a value indicating whether this instance is the primary phone number.
            /// </summary>
            /// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
            [JsonProperty("primary")]
            public bool IsPrimary { get; set; }

            /// <summary>
            /// Gets or sets the number.
            /// </summary>
            /// <value>The number.</value>
            [JsonProperty("data")]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            public string Type { get; set; }
        }

        /// <summary>
        /// Represents and <see cref="Identity"/> email.
        /// </summary>
        public struct Email
        {
            /// <summary>
            /// Gets or sets the address.
            /// </summary>
            /// <value>The address.</value>
            [JsonProperty("data")]
            public string Address { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether this instance is the primary email.
            /// </summary>
            /// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
            [JsonProperty("primary")]
            public bool IsPrimary { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            public string Type { get; set; }
        }

        /// <summary>
        /// Represents an <see cref="Identity"/> address.
        /// </summary>
        public struct Address
        {
            /// <summary>
            /// Gets or sets a value indicating whether this instance is the primary address.
            /// </summary>
            /// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
            [JsonProperty("primary")]
            public bool IsPrimary { get; set; }

            /// <summary>
            /// Gets or sets the account names.
            /// </summary>
            /// <value>The accounts.</value>
            public string[] Accounts { get; set; }

            /// <summary>
            /// Gets or sets the address data (city, state, etc).
            /// </summary>
            /// <value>The information.</value>
            [JsonProperty("data")]
            public Data Info { get; set; }

            /// <summary>
            /// Represents the fields of an address.
            /// </summary>
            public struct Data
            {
                /// <summary>
                /// Gets or sets the street.
                /// </summary>
                /// <value>The street.</value>
                [JsonProperty("street")]
                public string Street { get; set; }

                /// <summary>
                /// Gets or sets the city.
                /// </summary>
                /// <value>The city.</value>
                [JsonProperty("city")]
                public string City { get; set; }

                /// <summary>
                /// Gets or sets the state.
                /// </summary>
                /// <value>The state.</value>
                [JsonProperty("state")]
                public string State { get; set; }

                /// <summary>
                /// Gets or sets the zip.
                /// </summary>
                /// <value>The zip.</value>
                [JsonProperty("postal_code")]
                public string Zip { get; set; }

                /// <summary>
                /// Gets or sets the zip.
                /// </summary>
                /// <value>The zip.</value>
                [JsonProperty("country")]
                public string Country { get; set; }
            }
        }

        #endregion Structs
    }
}