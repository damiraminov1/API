import React, { useState, useRef } from "react";
import { Button, Space, Descriptions, DescriptionsProps } from "antd";
import { useParams } from "@umijs/max";
import request from "@/utils/request";
import ReactToPrint from "react-to-print";
import { Pie } from "@ant-design/plots";



const PrintComponent = ({ data, items, items2, items3, charts, config }) => (
  <>
    <Space direction="vertical" style={{ marginBottom: '10px' }}></Space>

    <div>
      <h2 style={{ textAlign: 'center' }}>Исходные данные</h2>
      <Descriptions
        bordered
        layout="vertical"
        size="middle"
        items={items3}
      />
    </div>

    <div>
      <h2 style={{ textAlign: 'center' }}>Итоговые расчетные показатели</h2>
      <Descriptions
        bordered
        layout="vertical"
        size="middle"
        items={items2}
      />
    </div>

    <div>
      <h2 style={{ textAlign: 'center' }}>Промежуточные расчетные показатели</h2>
      <Descriptions
        bordered
        layout="vertical"
        labelStyle={{ textAlign: 'center' }}
        size="middle"
        items={items}
      />
    </div>

    <div style={{ textAlign: 'center' }}>
      <h2>Тепловой баланс</h2>
      <Pie {...config} />
    </div>
  </>
);

const DocsPage = (props) => {
  const params = useParams();
  const [data, setData] = useState<any>();
  const [currentDateTime, setCurrentDateTime] = useState(new Date());
  const componentRef = useRef();

  React.useEffect(() => {
    request(`https://localhost:7173/Report/Report?id=${params.id}`).then((result) => {
      console.log(result);
      setData(result);
    });
    document.title = `Отчет ${data?.dataInput.name}`
  }, []);

  const roundNumber = (value) => {
    return Number(value).toFixed(3);
  };

  const items3 = [
    { label: 'Название варианта исходных данных', children: data?.dataInput.name, span: 2 },
    { label: 'Описание', children: data?.dataInput.description, },
    { label: 'Начальная влажность материала', children: roundNumber(data?.dataInput.wstart), },
    { label: 'Конечная влажность материала', children: roundNumber(data?.dataInput.wend), },
    { label: 'Содержание углерода в топливе', children: roundNumber(data?.dataInput.percentCp), },
    { label: 'Содержание водорода в топливе', children: roundNumber(data?.dataInput.percentHp), },
    { label: 'Содержание серы в топливе', children: roundNumber(data?.dataInput.percentSp), },
    { label: 'Содержание кислорода в топливе', children: roundNumber(data?.dataInput.percentOp), },
    { label: 'Содержание азота в топливе', children: roundNumber(data?.dataInput.percentNp), },
    { label: 'Содержание золы в топливе', children: roundNumber(data?.dataInput.percentAp), },
    { label: 'Содержание влаги в топливе', children: roundNumber(data?.dataInput.percentWp), },
    { label: 'Максимальная температура газов, градусов цельсия', children: roundNumber(data?.dataInput.t1), },
    { label: 'Минимальная температура газов, градусов цельсия', children: roundNumber(data?.dataInput.t2), },
    { label: 'Коэффициент расхода воздуха', children: roundNumber(data?.dataInput.alpha), },
    { label: 'Коэффициент сохранения тепла', children: roundNumber(data?.dataInput.eta), },
    { label: 'Температура воздуха, градусов цеьсия', children: roundNumber(data?.dataInput.tair), },
    { label: 'Температура газов, градусов цеьсия', children: roundNumber(data?.dataInput.tgase), },
    { label: 'Средняя по массе начальная температура материала, градусов цельсия', children: roundNumber(data?.dataInput.tm1), },
    { label: 'Требуемая производительность, кг/ч', children: roundNumber(data?.dataInput.gt), },
    { label: 'Процент химического недожога', children: roundNumber(data?.dataInput.him), },
    { label: 'Объемное отношение кислорода к азоту в воздухе', children: roundNumber(data?.dataInput.k), },
    { label: 'Удельная теплоемкость газов, кДж/(кг*К)', children: roundNumber(data?.dataInput.cgase), },
    { label: 'Удельная теплоемкость сухого материала, кДж/(кг*К)', children: roundNumber(data?.dataInput.cmaterial), },
    { label: 'Удельная теплоемкость влаги, кДж/(кг*К)', children: roundNumber(data?.dataInput.cwet), },
    { label: 'Энтальпия водяного пара при 100 градусах цельсия, кДж/кг', children: roundNumber(data?.dataInput.enthalpy100), },
    { label: 'Диаметр барабана, м', children: roundNumber(data?.dataInput.d), },
    { label: 'Длина барабана, м', children: roundNumber(data?.dataInput.l), },



  ];

    const items: DescriptionsProps['items'] = [
        { label: 'Удельная теплоемкость воздуха, кДж/(кг*К)', children: roundNumber(data?.result.cair), },
        { label: 'Начальная энтальпия воды, кДж/кг', children: roundNumber(data?.result.enthalpyWater), },
        { label: 'Удельная теплоемкость пара, кДж/кг', children: roundNumber(data?.result.csteam), },
        { label: 'Выход CO2 в продуктах горения, м3/кг', children: roundNumber(data?.result.exitCO2), },
        { label: 'Выход SO2 в продуктах горения, м3/кг', children: roundNumber(data?.result.exitSO2), },
        { label: 'Выход H2O в продуктах горения, м3/кг', children: roundNumber(data?.result.exitH2O), },
        { label: 'Расход кислорода на горение, м3/кг', children: roundNumber(data?.result.consumptionO2), },
        { label: 'Выход N2 в продуктах горения, м3/кг', children: roundNumber(data?.result.exitN2), },
        { label: 'Действительный выход N2 в продуктах горения, м3/кг', children: roundNumber(data?.result.realexitN2), },
        { label: 'Избыточный объем кислорода, м3/кг', children: roundNumber(data?.result.overageO2), },
        { label: 'Теоретический расход воздуха, м3/кг', children: roundNumber(data?.result.theoryСonsAir), },
        { label: 'Действительный расход сухого воздуха, м3/кг', children: roundNumber(data?.result.realConsDryAir), },
        { label: 'Выход продуктов горения, м3/кг', children: roundNumber(data?.result.exitCombusProd), },
        { label: 'Теплота сгорания мазута, кДж/кг', children: roundNumber(data?.result.qfuel), },
        { label: 'Содержание воздуха в продуктах сгорания, %', children: roundNumber(data?.result.percentAir), },
        { label: 'Балансовая энтальпия продуктов горения, кДж/м3', children: roundNumber(data?.result.balanceEntCombusProd), },
        { label: 'Балансовая температура продуктов горения, ℃', children: roundNumber(data?.result.balanceTempCombusProd), },
        { label: 'Энтальпия факела, кДж/м3', children: roundNumber(data?.result.enthalpyTorch), },
        { label: 'Энтальпия воздуха, кДж/м3', children: roundNumber(data?.result.enthalpyAir), },
        { label: 'Энтальпия продуктов сгорания, кДж/м3', children: roundNumber(data?.result.enthalpyCombusProd), },
        { label: 'Энтальпия дымовых газов, кДж/м3', children: roundNumber(data?.result.enthalpyFlueGases), },
        { label: 'Количество воздуха, м3/м3', children: roundNumber(data?.result.airAmount), },
        { label: 'Энтальпия воздуха при t2 и VL = 100%, кДж/м3', children: roundNumber(data?.result.enthalpyAir100), },
        { label: 'Средняя по массе температура материала в конце сушки, ℃', children: roundNumber(data?.result.middleTempEnd), },
        { label: 'Температура стенки в начале барабана, ℃', children: roundNumber(data?.result.startTempWall), },
        { label: 'Температура стенки в конце барабана, ℃', children: roundNumber(data?.result.endTempWall), },
        { label: 'Средняя температура металлической стенки барабана, ℃', children: roundNumber(data?.result.middleTempWall), },
        { label: 'Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, Вт/(м2*К)', children: roundNumber(data?.result.alphaHeatTrans), },
        { label: 'Влажность в % от неизменяющейся сухой массы материала в начале сушки, %', children: roundNumber(data?.result.startMaterialWet), },
        { label: 'Влажность в % от неизменяющейся сухой массы материала в конце сушки, %', children: roundNumber(data?.result.endMaterialWet), },
        { label: 'Производительность по испарённой влаге, кг/ч', children: roundNumber(data?.result.wetEfficiency), },
        { label: 'Q2*B, кВт*кг/ч', children: roundNumber(data?.result.q2B), },
        { label: 'Q3*B, кВт*кг/ч', children: roundNumber(data?.result.q3B), },
        { label: 'Q5топ*B, кВт*кг/ч', children: roundNumber(data?.result.q5tpoB), },
    ];
    const items2: DescriptionsProps['items'] = [
        { label: 'Расход теплоты на прогревание просушиваемых материалов и испарение влаги, кВт', children: roundNumber(data?.result.q1), },
        { label: 'Потери теплоты вследствие теплопроводности стенок рабочего пространства, кВт', children: roundNumber(data?.result.q5t), },
        { label: 'Расход мазута, кг/ч', children: roundNumber(data?.result.b), },
        { label: 'Тепловая мощность печи, кВт', children: roundNumber(data?.result.qh), },
        { label: 'Расход теплоты на 1 кг испаренной влаги, кДж/кг', children: roundNumber(data?.result.qevapor), },
        { label: 'Потери теплоты с отходящими газами, кВт', children: roundNumber(data?.result.q2), },
        { label: 'Потери теплоты с химическим недожогом, кВт', children: roundNumber(data?.result.q3), },
        { label: 'Потери теплоты топкой, кВт', children: roundNumber(data?.result.q5top), },
        { label: 'Коэффициент полезного действия печи, %', children: roundNumber(data?.result.percentQ1), },
        { label: '%Q2, %', children: roundNumber(data?.result.percentQ2), },
        { label: '%Q3, %', children: roundNumber(data?.result.percentQ3), },
        { label: '%Q5топ, %', children: roundNumber(data?.result.percentQ5top), },
        { label: '%Q5т, %', span: 3, children: roundNumber(data?.result.percentQ5t), },
    ];

  const charts = [
    { type: 'Q1', value: data?.result.percentQ1, },
    { type: 'Q2', value: data?.result.percentQ2, },
    { type: 'Q3', value: data?.result.percentQ3, },
    { type: 'Q5t', value: data?.result.percentQ5t, },
    { type: 'Q5top', value: data?.result.percentQ5top, },
  ];

  const config = {
    appendPadding: 40,
    data: charts,
    angleField: 'value',
    colorField: 'type',
    radius: 0.8,
    label: {
      type: 'outer',
      content: '{name} {percentage}',
    },
    interactions: [
      {
        type: 'pie-legend-active',
      },
      {
        type: 'element-active',
      },
    ],
  };

  return (
    <>
      <ReactToPrint
        trigger={() => (
          <Button type="primary">
            Печать
          </Button>
        )}
        content={() => componentRef.current}
      />
      <div ref={componentRef}>
        <PrintComponent
          data={data}
          items={items}
          items2={items2}
          items3={items3}
          charts={charts}
          config={config}
        />
      </div>
    </>
  );
};

export default DocsPage;