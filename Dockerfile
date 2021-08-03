FROM node

WORKDIR /usr/ClientApp/src/app

COPY package*.json ./

RUN npm install

COPY . .

EXPOSE 4000
CMD ["npm", "start"]