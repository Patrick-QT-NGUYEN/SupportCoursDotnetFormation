using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoursJWTApiRestFull.Services
{
    public class TokenService
    {


        public string Authenticate(string username , string password)
        {
            // Logique métier pour verifier l'existance de l'utilisateur

            if (username =="toto" && password =="tata")
            {
                // Création d'un instance de JWT Handler
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                // Configuration du Token
                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
                {
                    //Expires = DateTime.Now.AddHours(2),
                    Expires = DateTime.Now.AddMinutes(2),
                    //Expires = DateTime.Now.AddMinutes(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = "m2i",
                    Audience = "m2i",
                    // Création des role pour mon application
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("role", "admin")
                    })
                };
                // Création du token avec les params ci-dessus
                SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);
                // Retour du token à l'utilisateur
                return tokenHandler.WriteToken(token);
            }
            return "Erreur! Utilisateur non reconnu...";
        }
    }
}
