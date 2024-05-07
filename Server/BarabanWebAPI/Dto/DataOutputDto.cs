namespace BarabanWebAPI.Dto
{
    public class DataOutputDto
    {

        /// <summary>
        /// Удельная теплоемкость воздуха, кДж/(кг*К) (св)
        /// </summary>         
        public double Cair { get; set; }

        /// <summary>
        /// Начальная энтальпия воды, кДж/кг (i1вл)
        /// </summary>  
        public double enthalpyWater { get; set; }

        /// <summary>
        /// Удельная теплоемкость пара, кДж/кг (сп)
        /// </summary>  
        public double Csteam { get; set; }

        /// <summary>
        /// Выход CO2 в продуктах горения, м3/кг (V0CO2)
        /// </summary>  
        public double exitCO2 { get; set; }

        /// <summary>
        /// Выход SO2 в продуктах горения, м3/кг (V0SO2)
        /// </summary> 
        public double exitSO2 { get; set; }

        /// <summary>
        /// Выход H2O в продуктах горения, м3/кг (V0H2O)
        /// </summary> 
        public double exitH2O { get; set; }

        /// <summary>
        /// Расход кислорода на горение, м3/кг (VO2)
        /// </summary> 
        public double consumptionO2
        {
            get; set;
        }

        /// <summary>
        /// Выход N2 в продуктах горения, м3/кг (V0N2)
        /// </summary>  
        public double exitN2
        {
            get; set;
        }

        /// <summary>
        /// Действительный выход N2 в продуктах горения, м3/кг (VaN2)
        /// </summary>  
        public double realexitN2
        {
            get; set;
        }

        /// <summary>
        /// Избыточный объем кислорода, м3/кг (VО2изб)
        /// </summary>  
        public double overageO2
        {
            get; set;
        }

        /// <summary>
        /// Теоретический расход воздуха, м3/кг (L0)
        /// </summary>  
        public double theoryСonsAir
        {
            get; set;
        }

        /// <summary>
        /// Действительный расход сухого воздуха, м3/кг (Lalpha)
        /// </summary> 
        public double realConsDryAir
        {
            get; set;
        }

        /// <summary>
        /// Выход продуктов горения, м3/кг (Valpha1)
        /// </summary> 
        public double exitCombusProd
        {
            get; set;
        }

        /// <summary>
        /// Теплота сгорания мазута, кДж/кг (Qнр)
        /// </summary> 
        public double Qfuel
        {
            get; set;
        }

        /// <summary>
        /// Содержание воздуха в продуктах сгорания, % (VL)
        /// </summary>  
        public double percentAir
        {
            get; set;
        }

        /// <summary>
        /// Балансовая энтальпия продуктов горения, кДж/м3 (iбобщ)
        /// </summary> 
        public double balanceEntCombusProd
        {
            get; set;
        }

        /// <summary>
        /// Балансовая температура продуктов горения, градусов цельсия (tab)
        /// </summary>  
        public double balanceTempCombusProd
        {
            get; set;
        }

        /// <summary>
        /// Энтальпия факела, кДж/м3 (iф)
        /// </summary> 
        public double enthalpyTorch
        {
            get; set;
        }

        /// <summary>
        /// Энтальпия воздуха, кДж/м3 (iв)
        /// </summary> 
        public double enthalpyAir
        {
            get; set;
        }

        /// <summary>
        /// Энтальпия продуктов сгорания, кДж/м3 (i1)
        /// </summary> 
        public double enthalpyCombusProd
        {
            get; set;
        }

        /// <summary>
        /// Энтальпия дымовых газов, кДж/м3 (i2)
        /// </summary> 
        public double enthalpyFlueGases
        {
            get; set;
        }

        /// <summary>
        /// Количество воздуха, м3/м3 (хв)
        /// </summary> 
        public double airAmount
        {
            get; set;
        }

        /// <summary>
        /// Энтальпия воздуха при t2 и VL = 100%, кДж/м3 (i2в)
        /// </summary> 
        public double enthalpyAir100
        {
            get; set;
        }

        /// <summary>
        /// Средняя по массе температура материала в конце сушки, градусов цельсия (tм2)
        /// </summary> 
        public double middleTempEnd
        {
            get; set;
        }

        /// <summary>
        /// Температура стенки в начале барабана, градусов цельсия (tстнач)
        /// </summary> 
        public double startTempWall
        {
            get; set;
        }

        /// <summary>
        /// Температура стенки в конце барабана, градусов цельсия (tсткон)
        /// </summary>  
        public double endTempWall
        {
            get; set;
        }

        /// <summary>
        /// Средняя температура металлической стенки барабана, градусов цельсия (tст)
        /// </summary>  
        public double middleTempWall
        {
            get; set;
        }

        /// <summary>
        /// Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, Вт/(м2*К) (alphaв)
        /// </summary>  
        public double alphaHeatTrans
        {
            get; set;
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в начале сушки, % (W1c)
        /// </summary> 
        public double startMaterialWet
        {
            get; set;
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в конце сушки, % (W2c)
        /// </summary>  
        public double endMaterialWet
        {
            get; set;
        }

        /// <summary>
        /// Производительность по испарённой влаге, кг/ч (Gвл)
        /// </summary> 
        public double WetEfficiency
        {
            get; set;
        }

        /// <summary>
        /// Q2*B, кВт*кг/ч (Q2В)
        /// </summary> 
        public double Q2B
        {
            get; set;
        }

        /// <summary>
        /// Q3*B, кВт*кг/ч (Q3В)
        /// </summary>  
        public double Q3B
        {
            get; set;
        }

        /// <summary>
        /// Q5топ*B, кВт*кг/ч (Q5топВ)
        /// </summary> 
        public double Q5tpoB
        {
            get; set;
        }

        /// <summary>
        /// Расход теплоты на прогревание просушиваемых материалов и испарение влаги, кВт (Q1)
        /// </summary>  
        public double Q1
        {
            get; set;
        }

        /// <summary>
        /// Потери теплоты вследствие теплопроводности стенок рабочего пространства, кВт (Q5т)
        /// </summary> 
        public double Q5t
        {
            get; set;
        }

        /// <summary>
        /// Расход мазута, кг/ч (B)
        /// </summary> 
        public double B
        {
            get; set;
        }

        /// <summary>
        /// Тепловая мощность печи, кВт (Qх)
        /// </summary>  
        public double Qh
        {
            get; set;
        }

        /// <summary>
        /// Расход теплоты на 1 кг испаренной влаги, кДж/кг (qисп)
        /// </summary> 
        public double qevapor
        {
            get; set;
        }

        /// <summary>
        /// Потери теплоты с отходящими газами, кВт (Q2)
        /// </summary> 
        public double Q2
        {
            get; set;
        }

        /// <summary>
        /// Потери теплоты с химическим недожогом, кВт (Q3)
        /// </summary>  
        public double Q3
        {
            get; set;
        }

        /// <summary>
        /// Потери теплоты топкой, кВт (Q5топ)
        /// </summary> 
        public double Q5top
        {
            get; set;
        }

        /// <summary>
        /// Коэффициент полезного действия печи, % (%Q1)
        /// </summary> 
        public double percentQ1
        {
            get; set;
        }

        /// <summary>
        /// %Q2, % (%Q2)
        /// </summary> 
        public double percentQ2
        {
            get; set;
        }

        /// <summary>
        /// %Q3, % (%Q3)
        /// </summary> 
        public double percentQ3 { get; set; }

        /// <summary>
        /// %Q5топ, % (%Qтоп)
        /// </summary> 
        public double percentQ5top { get; set; }

        /// <summary>
        /// %Q5т, % (%Qт)
        /// </summary> 
        public double percentQ5t { get; set; }

    }
}
