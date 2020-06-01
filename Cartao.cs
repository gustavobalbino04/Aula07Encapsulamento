namespace Aula07Encapsulamento
{
    public class Cartao
    {
        //get-formato leitura/set-bloquear
         public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        private string token = "iojsdif98734riukjsdf87f6487ryuhrfsefy983479875uo4i3hr984735904uriofwef897f89ew7ferf";
        protected int cvc { get; set; }

        /// <summary>
        /// compra
        /// </summary>
        /// <returns>aprovar compra</returns>
        public string AprovarCompra(){
            return "Compra Aprovada";
        }
        /// <summary>
        /// validaçao do token
        /// </summary>
        /// <returns>verificaçao do tuken diferente 0</returns>
        private bool ValidarToken(){

            if(token != null && token != ""){
                return true;
            }
            return false;
        }
        /// <summary>
        /// validar compra
        /// </summary>
        /// <returns>validação do compra</returns>
        protected bool ValidarCompra(){
            return true;
        }
       
    }
}