# устанавливаем официальный образ Node.js
FROM node:10.5.0

# копируем основные файлы приложения в рабочую директорию
COPY . .

# устанавливаем указанные зависимости NPM на этапе установки образа
# RUN npm install

# после установки копируем все файлы проекта в корневую директорию
# COPY . ./

# запускаем основной скрипт в момент запуска контейнера
CMD npm start --prefix Client/