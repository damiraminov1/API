import request from "@/utils/request";
import { Link, useParams } from "@umijs/max";
import { Space, DescriptionsProps, Descriptions, Button, Form } from "antd";
import React, { useState } from "react";

const DocsPage = (props: any) => {
  const params = useParams();
  const [data, setData] = React.useState<any>();
  const [descriptionsVisible, setDescriptionsVisible] = useState(false);

  React.useEffect(() => {
    request(`https://localhost:7213/Calc/Calc?id=${params.id}`).then(result => {
      console.log(result);
      setData(result)
    });
  }, []);

  const roundNumber = (value) => {
    // Округлить значение до двух знаков после запятой
    return Number(value).toFixed(3);
  };

  const items: DescriptionsProps['items'] = [
    { label: 'Удельная теплоемкость воздуха, кДж/(кг*К)', children: roundNumber(data?.cair), },
    { label: 'Начальная энтальпия воды, кДж/кг', children: roundNumber(data?.enthalpyWater), },
    { label: 'Удельная теплоемкость пара, кДж/кг', children: roundNumber(data?.csteam), },
    { label: 'Выход CO2 в продуктах горения, м3/кг', children: roundNumber(data?.exitCO2), },
    { label: 'Выход SO2 в продуктах горения, м3/кг', children: roundNumber(data?.exitSO2), },
    { label: 'Выход H2O в продуктах горения, м3/кг', children: roundNumber(data?.exitH2O), },
    { label: 'Расход кислорода на горение, м3/кг', children: roundNumber(data?.consumptionO2), },
    { label: 'Выход N2 в продуктах горения, м3/кг', children: roundNumber(data?.exitN2), },
    { label: 'Действительный выход N2 в продуктах горения, м3/кг', children: roundNumber(data?.realexitN2), },
    { label: 'Избыточный объем кислорода, м3/кг', children: roundNumber(data?.overageO2), },
    { label: 'Теоретический расход воздуха, м3/кг', children: roundNumber(data?.theoryСonsAir), },
    { label: 'Действительный расход сухого воздуха, м3/кг', children: roundNumber(data?.realConsDryAir), },
    { label: 'Выход продуктов горения, м3/кг', children: roundNumber(data?.exitCombusProd), },
    { label: 'Теплота сгорания мазута, кДж/кг', children: roundNumber(data?.qfuel), },
    { label: 'Содержание воздуха в продуктах сгорания, %', children: roundNumber(data?.percentAir), },
    { label: 'Балансовая энтальпия продуктов горения, кДж/м3', children: roundNumber(data?.balanceEntCombusProd), },
    { label: 'Балансовая температура продуктов горения, ℃', children: roundNumber(data?.balanceTempCombusProd), },
    { label: 'Энтальпия факела, кДж/м3', children: roundNumber(data?.enthalpyTorch), },
    { label: 'Энтальпия воздуха, кДж/м3', children: roundNumber(data?.enthalpyAir), },
    { label: 'Энтальпия продуктов сгорания, кДж/м3', children: roundNumber(data?.enthalpyCombusProd), },
    { label: 'Энтальпия дымовых газов, кДж/м3', children: roundNumber(data?.enthalpyFlueGases), },
    { label: 'Количество воздуха, м3/м3', children: roundNumber(data?.airAmount), },
    { label: 'Энтальпия воздуха при t2 и VL = 100%, кДж/м3', children: roundNumber(data?.enthalpyAir100), },
    { label: 'Средняя по массе температура материала в конце сушки, ℃', children: roundNumber(data?.middleTempEnd), },
    { label: 'Температура стенки в начале барабана, ℃', children: roundNumber(data?.startTempWall), },
    { label: 'Температура стенки в конце барабана, ℃', children: roundNumber(data?.endTempWall), },
    { label: 'Средняя температура металлической стенки барабана, ℃', children: roundNumber(data?.middleTempWall), },
    { label: 'Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, Вт/(м2*К)', children: roundNumber(data?.alphaHeatTrans), },
    { label: 'Влажность в % от неизменяющейся сухой массы материала в начале сушки, %', children: roundNumber(data?.startMaterialWet), },
    { label: 'Влажность в % от неизменяющейся сухой массы материала в конце сушки, %', children: roundNumber(data?.endMaterialWet), },
    { label: 'Производительность по испарённой влаге, кг/ч', children: roundNumber(data?.wetEfficiency), },
    { label: 'Q2*B, кВт*кг/ч', children: roundNumber(data?.q2B), },
    { label: 'Q3*B, кВт*кг/ч', children: roundNumber(data?.q3B), },
    { label: 'Q5топ*B, кВт*кг/ч', children: roundNumber(data?.q5tpoB), },
  ];
  const items2: DescriptionsProps['items'] = [
    { label: 'Расход теплоты на прогревание просушиваемых материалов и испарение влаги, кВт', children: roundNumber(data?.q1), },
    { label: 'Потери теплоты вследствие теплопроводности стенок рабочего пространства, кВт', children: roundNumber(data?.q5t), },
    { label: 'Расход мазута, кг/ч', children: roundNumber(data?.b), },
    { label: 'Тепловая мощность печи, кВт', children: roundNumber(data?.qh), },
    { label: 'Расход теплоты на 1 кг испаренной влаги, кДж/кг', children: roundNumber(data?.qevapor), },
    { label: 'Потери теплоты с отходящими газами, кВт', children: roundNumber(data?.q2), },
    { label: 'Потери теплоты с химическим недожогом, кВт', children: roundNumber(data?.q3), },
    { label: 'Потери теплоты топкой, кВт', children: roundNumber(data?.q5top), },
    { label: 'Коэффициент полезного действия печи, %', children: roundNumber(data?.percentQ1), },
    { label: '%Q2, %', children: roundNumber(data?.percentQ2), },
    { label: '%Q3, %', children: roundNumber(data?.percentQ3), },
    { label: '%Q5топ, %', children: roundNumber(data?.percentQ5top), },
    { label: '%Q5т, %', span: 3, children: roundNumber(data?.percentQ5t), },
  ];

  const handleToggleDescriptions = () => {
    setDescriptionsVisible(!descriptionsVisible);
  };

  return (
    <>
      <Space direction="horizontal" style={{ marginBottom: '10px' }}>
        <Button type="primary" onClick={handleToggleDescriptions}>
          {descriptionsVisible ? 'Скрыть промежуточные расчетные показатели' : 'Показать промежуточные расчетные показатели'}
        </Button>
        <Link to={`/report/${params.id}`}> 
            <Button type="primary">Печать</Button>
        </Link>
      </Space>
      <div>
        <h2 style={{ textAlign: 'center' }}>Итоговые расчетные показатели</h2>
        <Descriptions
          bordered
          layout="vertical"
          size="middle"
          items={items2} />
      </div>

      {descriptionsVisible && (
        <div>
          <h2 style={{ textAlign: 'center' }}>Промежуточные расчетные показатели</h2>
          <Descriptions
            bordered
            layout="vertical"
            labelStyle={{ textAlign: 'center' }}
            size="middle"
            items={items} />
        </div>
      )}


    </>
  );

}
export default DocsPage;