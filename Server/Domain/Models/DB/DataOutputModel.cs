using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.DB
{
    public class DataOutputModel
    {
        private MathLibrary _m = new MathLibrary();
        public DataInputModel DataInput = new DataInputModel();

        public DataOutputModel() { }

        public DataOutputModel(DataInputModel dataInput)
        {
            DataInput = dataInput;

            #region --- Передать исходные данные в экземпляр библиотеки

            _m.Wstart = DataInput.Wstart;
            _m.Wend = DataInput.Wend;
            _m.percentCp = DataInput.percentCp;
            _m.percentHp = DataInput.percentHp;
            _m.percentSp = DataInput.percentSp;
            _m.percentOp = DataInput.percentOp;
            _m.percentNp = DataInput.percentNp;
            _m.percentAp = DataInput.percentAp;
            _m.percentWp = DataInput.percentWp;
            _m.t1 = DataInput.t1;
            _m.t2 = DataInput.t2;
            _m.alpha = DataInput.alpha;
            _m.eta = DataInput.eta;
            _m.tair = DataInput.tair;
            _m.tgase = DataInput.tgase;
            _m.tm1 = DataInput.tm1;
            _m.Gt = DataInput.Gt;
            _m.Him = DataInput.Him;
            _m.k = DataInput.k;
            _m.Cgase = DataInput.Cgase;
            _m.Cmaterial = DataInput.Cmaterial;
            _m.Cwet = DataInput.Cwet;
            _m.enthalpy100 = DataInput.enthalpy100;
            _m.D = DataInput.D;
            _m.L = DataInput.L;

            #endregion --- Передать исходные данные в экземпляр библиотеки
        }

        #region --- Получить промежуточные расчетные показатели

        /// <summary>
        /// Удельная теплоемкость воздуха, кДж/(кг*К) (св)
        /// </summary>         
        public double Cair
        {
            get { return _m.Cair; } 
        }

        /// <summary>
        /// Начальная энтальпия воды, кДж/кг (i1вл)
        /// </summary>  
        public double enthalpyWater
        {
            get { return _m.enthalpyWater; }
        }

        /// <summary>
        /// Удельная теплоемкость пара, кДж/кг (сп)
        /// </summary>  
        public double Csteam
        {
            get { return _m.Csteam; }
        }

        /// <summary>
        /// Выход CO2 в продуктах горения, м3/кг (V0CO2)
        /// </summary>  
        public double exitCO2
        {
            get { return _m.exitCO2; }
        }

        /// <summary>
        /// Выход SO2 в продуктах горения, м3/кг (V0SO2)
        /// </summary> 
        public double exitSO2
        {
            get { return _m.exitSO2; }
        }

        /// <summary>
        /// Выход H2O в продуктах горения, м3/кг (V0H2O)
        /// </summary> 
        public double exitH2O
        {
            get { return _m.exitH2O; }
        }

        /// <summary>
        /// Расход кислорода на горение, м3/кг (VO2)
        /// </summary> 
        public double consumptionO2
        {
            get { return _m.consumptionO2; }
        }

        /// <summary>
        /// Выход N2 в продуктах горения, м3/кг (V0N2)
        /// </summary>  
        public double exitN2
        {
            get { return _m.exitN2; }
        }

        /// <summary>
        /// Действительный выход N2 в продуктах горения, м3/кг (VaN2)
        /// </summary>  
        public double realexitN2
        {
            get { return _m.realexitN2; }
        }

        /// <summary>
        /// Избыточный объем кислорода, м3/кг (VО2изб)
        /// </summary>  
        public double overageO2
        {
            get { return _m.overageO2; }
        }

        /// <summary>
        /// Теоретический расход воздуха, м3/кг (L0)
        /// </summary>  
        public double theoryСonsAir
        {
            get { return _m.theoryСonsAir; }
        }

        /// <summary>
        /// Действительный расход сухого воздуха, м3/кг (Lalpha)
        /// </summary> 
        public double realConsDryAir
        {
            get { return _m.realConsDryAir; }
        }

        /// <summary>
        /// Выход продуктов горения, м3/кг (Valpha1)
        /// </summary> 
        public double exitCombusProd
        {
            get { return _m.exitCombusProd; }
        }

        /// <summary>
        /// Теплота сгорания мазута, кДж/кг (Qнр)
        /// </summary> 
        public double Qfuel
        {
            get { return _m.Qfuel; }
        }

        /// <summary>
        /// Содержание воздуха в продуктах сгорания, % (VL)
        /// </summary>  
        public double percentAir
        {
            get { return _m.percentAir; }
        }

        /// <summary>
        /// Балансовая энтальпия продуктов горения, кДж/м3 (iбобщ)
        /// </summary> 
        public double balanceEntCombusProd
        {
            get { return _m.balanceEntCombusProd; }
        }

        /// <summary>
        /// Балансовая температура продуктов горения, градусов цельсия (tab)
        /// </summary>  
        public double balanceTempCombusProd
        {
            get { return _m.balanceTempCombusProd; }
        }

        /// <summary>
        /// Энтальпия факела, кДж/м3 (iф)
        /// </summary> 
        public double enthalpyTorch
        {
            get { return _m.enthalpyTorch; }
        }

        /// <summary>
        /// Энтальпия воздуха, кДж/м3 (iв)
        /// </summary> 
        public double enthalpyAir
        {
            get { return _m.enthalpyAir; }
        }

        /// <summary>
        /// Энтальпия продуктов сгорания, кДж/м3 (i1)
        /// </summary> 
        public double enthalpyCombusProd
        {
            get { return _m.enthalpyCombusProd; }
        }

        /// <summary>
        /// Энтальпия дымовых газов, кДж/м3 (i2)
        /// </summary> 
        public double enthalpyFlueGases
        {
            get { return _m.enthalpyFlueGases; }
        }

        /// <summary>
        /// Количество воздуха, м3/м3 (хв)
        /// </summary> 
        public double airAmount
        {
            get { return _m.airAmount; }
        }

        /// <summary>
        /// Энтальпия воздуха при t2 и VL = 100%, кДж/м3 (i2в)
        /// </summary> 
        public double enthalpyAir100
        {
            get { return _m.enthalpyAir100; }
        }

        /// <summary>
        /// Средняя по массе температура материала в конце сушки, градусов цельсия (tм2)
        /// </summary> 
        public double middleTempEnd
        {
            get { return _m.middleTempEnd; }
        }

        /// <summary>
        /// Температура стенки в начале барабана, градусов цельсия (tстнач)
        /// </summary> 
        public double startTempWall
        {
            get { return _m.startTempWall; }
        }

        /// <summary>
        /// Температура стенки в конце барабана, градусов цельсия (tсткон)
        /// </summary>  
        public double endTempWall
        {
            get { return _m.endTempWall; }
        }

        /// <summary>
        /// Средняя температура металлической стенки барабана, градусов цельсия (tст)
        /// </summary>  
        public double middleTempWall
        {
            get { return _m.middleTempWall; }
        }

        /// <summary>
        /// Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, Вт/(м2*К) (alphaв)
        /// </summary>  
        public double alphaHeatTrans
        {
            get { return _m.alphaHeatTrans; }
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в начале сушки, % (W1c)
        /// </summary> 
        public double startMaterialWet
        {
            get { return _m.startMaterialWet; }
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в конце сушки, % (W2c)
        /// </summary>  
        public double endMaterialWet
        {
            get { return _m.endMaterialWet; }
        }

        /// <summary>
        /// Производительность по испарённой влаге, кг/ч (Gвл)
        /// </summary> 
        public double WetEfficiency
        {
            get { return _m.WetEfficiency; }
        }

        /// <summary>
        /// Q2*B, кВт*кг/ч (Q2В)
        /// </summary> 
        public double Q2B
        {
            get { return _m.Q2B; }
        }

        /// <summary>
        /// Q3*B, кВт*кг/ч (Q3В)
        /// </summary>  
        public double Q3B
        {
            get { return _m.Q3B; }
        }

        /// <summary>
        /// Q5топ*B, кВт*кг/ч (Q5топВ)
        /// </summary> 
        public double Q5tpoB
        {
            get { return _m.Q5topB; }
        }

        #endregion --- Получить промежуточные расчетные показатели

        #region --- Получить итоговые расчетные показатели

        /// <summary>
        /// Расход теплоты на прогревание просушиваемых материалов и испарение влаги, кВт (Q1)
        /// </summary>  
        public double Q1
        {
            get { return _m.Q1; }
        }

        /// <summary>
        /// Потери теплоты вследствие теплопроводности стенок рабочего пространства, кВт (Q5т)
        /// </summary> 
        public double Q5t
        {
            get { return _m.Q5t; }
        }

        /// <summary>
        /// Расход мазута, кг/ч (B)
        /// </summary> 
        public double B
        {
            get { return _m.B; }
        }

        /// <summary>
        /// Тепловая мощность печи, кВт (Qх)
        /// </summary>  
        public double Qh
        {
            get { return _m.Qh; }
        }

        /// <summary>
        /// Расход теплоты на 1 кг испаренной влаги, кДж/кг (qисп)
        /// </summary> 
        public double qevapor
        {
            get { return _m.qevapor; }
        }

        /// <summary>
        /// Потери теплоты с отходящими газами, кВт (Q2)
        /// </summary> 
        public double Q2
        {
            get { return _m.Q2; }
        }

        /// <summary>
        /// Потери теплоты с химическим недожогом, кВт (Q3)
        /// </summary>  
        public double Q3
        {
            get { return _m.Q3; }
        }

        /// <summary>
        /// Потери теплоты топкой, кВт (Q5топ)
        /// </summary> 
        public double Q5top
        {
            get { return _m.Q5top; }
        }

        /// <summary>
        /// Коэффициент полезного действия печи, % (%Q1)
        /// </summary> 
        public double percentQ1
        {
            get { return _m.percentQ1; }
        }

        /// <summary>
        /// %Q2, % (%Q2)
        /// </summary> 
        public double percentQ2
        {
            get { return _m.percentQ2; }
        }

        /// <summary>
        /// %Q3, % (%Q3)
        /// </summary> 
        public double percentQ3
        {
            get { return _m.percentQ3; }
        }

        /// <summary>
        /// %Q5топ, % (%Qтоп)
        /// </summary> 
        public double percentQ5top
        {
            get { return _m.percentQ5top; }
        }

        /// <summary>
        /// %Q5т, % (%Qт)
        /// </summary> 
        public double percentQ5t
        {
            get { return _m.percentQ5t; }
        }

        #endregion --- Получить итоговые расчетные показатели

    }
}
