namespace Domain.Models.DB
{
    public class DataInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }


        /// <summary>
        /// Начальная влажность материала, % (Wнач)
        /// </summary>         
        public double Wstart { get; set; }

        /// <summary>
        /// Конечная влажность материала, % (Wкон)
        /// </summary>         
        public double Wend { get; set; }

        /// <summary>
        /// Содержание углерода в топливе, % (%Ср)
        /// </summary> 
        public double percentCp { get; set; }

        /// <summary>
        /// Содержание водорода в топливе, % (%Hр)
        /// </summary> 
        public double percentHp { get; set; }

        /// <summary>
        /// Содержание серы в топливе, % (%Sр)
        /// </summary> 
        public double percentSp { get; set; }

        /// <summary>
        /// Содержание кислорода в топливе, % (%Oр)
        /// </summary>  
        public double percentOp { get; set; }

        /// <summary>
        /// Содержание азота в топливе, % (%Nр)
        /// </summary>  
        public double percentNp { get; set; }

        /// <summary>
        /// Содержание золы в топливе, % (%Aр)
        /// </summary> 
        public double percentAp { get; set; }

        /// <summary>
        /// Содержание влаги в топливе, % (%Wр)
        /// </summary> 
        public double percentWp { get; set; }

        /// <summary>
        /// Максимальная температура газов, градусов цельсия (t1)
        /// </summary> 
        public double t1 { get; set; }

        /// <summary>
        /// Минимальная температура газов, градусов цельсия (t2)
        /// </summary>  
        public double t2 { get; set; }

        /// <summary>
        /// Коэффициент расхода воздуха (alpha)
        /// </summary> 
        public double alpha { get; set; }

        /// <summary>
        /// Коэффициент сохранения тепла (eta)
        /// </summary> 
        public double eta { get; set; }

        /// <summary>
        /// Температура воздуха, °C (tв)
        /// </summary>         
        public double tair { get; set; }

        /// <summary>
        /// Температура газов, градусов цеьсия (tг)
        /// </summary> 
        public double tgase { get; set; }

        /// <summary>
        /// Средняя по массе начальная температура материала, градусов цельсия (tм1)
        /// </summary>  
        public double tm1 { get; set; }

        /// <summary>
        /// Требуемая производительность, кг/ч (Gт)
        /// </summary> 
        public double Gt { get; set; }

        /// <summary>
        /// Процент химического недожога, % (Him)
        /// </summary> 
        public double Him { get; set; }

        /// <summary>
        /// Объемное отношение кислорода к азоту в воздухе (k)
        /// </summary> 
        public double k { get; set; }

        /// <summary>
        /// Удельная теплоемкость газов, кДж/(кг*К) (cг)
        /// </summary> 
        public double Cgase { get; set; }

        /// <summary>
        /// Удельная теплоемкость сухого материала, кДж/(кг*К) (cм)
        /// </summary>  
        public double Cmaterial { get; set; }

        /// <summary>
        /// Удельная теплоемкость влаги, кДж/(кг*К) (cвл)
        /// </summary> 
        public double Cwet { get; set; }

        /// <summary>
        /// Энтальпия водяного пара при 100 градусах цельсия, кДж/кг (iп100)
        /// </summary> 
        public double enthalpy100 { get; set; }

        /// <summary>
        /// Диаметр барабана, м (D)
        /// </summary> 
        public double D { get; set; }

        /// <summary>
        /// Длина барабана, м (L)
        /// </summary> 
        public double L { get; set; }

        public static DataInputModel GetDefaultModel()
        {
            var _m = new DataInputModel();

            _m.Name = "Шаблонный вариант";
            _m.Description = "Пример";
            _m.Wstart = 10.000;
            _m.Wend = 0.500;
            _m.percentCp = 86.600;
            _m.percentHp = 10.400;
            _m.percentSp = 0.900;
            _m.percentOp = 0.400;
            _m.percentNp = 0.600;
            _m.percentAp = 0.300;
            _m.percentWp = 0.800;
            _m.t1 = 850.000;
            _m.t2 = 460.000;
            _m.alpha = 1.2;
            _m.eta = 0.9;
            _m.tair = 20d;
            _m.tgase = 20.000;
            _m.tm1 = 40.000;
            _m.Gt = 1.750;
            _m.Him = 0.020;
            _m.k = 3.760;
            _m.Cgase = 0.835;
            _m.Cmaterial = 0.880;
            _m.Cwet = 4.190;
            _m.enthalpy100 = 2675.000;
            _m.D = 1.000;
            _m.L = 4.000;

            _m.Id = 3;
            _m.IsActive = true;


            return _m;
        }
    }
}
