using System;

namespace KitchenShared.Models
{
    /// <summary>
    /// DTO (Data Transfer Object) to represent user login credentials
    /// </summary>
    public class LoginDto
    {
        /// <summary>
        /// Gets or sets the username of the user
        /// </summary>
        public string Username { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the password of the user
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
