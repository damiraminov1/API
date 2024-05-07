import React, { useEffect } from "react";

export default function HomePage() {
  useEffect(() => {
    // Change document title here
    document.title = "Главная";
  }, []);

  return (
    <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', height: '80vh' }}>
      <h1 style={{ textAlign: 'center' }}>Информационная система расчета теплового баланса сушильного агрегата</h1>
    </div>
  );
}