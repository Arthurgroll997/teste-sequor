namespace OrderManagerBack
{
    public static class Constants
    {
        public const int DEFAULT_SUCCESS_STATUS = 200;
        public const string APPOINTMENT_SUCCESS = "Sucesso no apontamento!";
        public const int DEFAULT_ERROR_STATUS = 201;
        public const string GENERIC_FAIL = "Falha no apontamento";
        public const string DEFAULT_SUCCESS_CHARACTER = "S";
        public const string DEFAULT_ERROR_CHARACTER = "E";

        public const string SET_PRODUCTION_INVALID_EMAIL = GENERIC_FAIL + " - Usuário não cadastrado!";
        public const string SET_PRODUCTION_INVALID_ORDER = GENERIC_FAIL + " - Ordem inválida!";
        public const string SET_PRODUCTION_INVALID_DATE = GENERIC_FAIL + " - Data de apontamento inválida!";
        public const string SET_PRODUCTION_INVALID_QUANTITY = GENERIC_FAIL + " - Quantidade inválida!";
        public const string SET_PRODUCTION_INVALID_MATERIAL = GENERIC_FAIL + " - Material Inválido!";
        
        public const string SET_PRODUCTION_INVALID_CYCLE_TIME = GENERIC_FAIL + " - Tempo de ciclo inválido!";
        public const string SET_PRODUCTION_CYCLE_TIME_WARNING = "Aviso - Tempo de ciclo menor que o cadastrado!";
    }
}
