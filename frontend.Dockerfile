# устанавливаем официальный образ Node.js
FROM node:22-alpine

# копируем основные файлы приложения в рабочую директорию
COPY . .

WORKDIR /Client
# устанавливаем указанные зависимости NPM на этапе установки образа
RUN npm install --force
RUN npm i yarn tyarn -g --force
RUN tyarn global add umi --force