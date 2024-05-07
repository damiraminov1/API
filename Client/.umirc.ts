import { defineConfig } from '@umijs/max';

export default defineConfig({
  antd: {},
  access: {},
  model: {},
  initialState: {},
  request: {},

 routes: [
  {
    path: '/',
    component: './index',
  },
  {
    path: '/raschet',
    component: './raschet',
  },
  
  {
    path: '/report/:id',
    component: './report/[id]',
  },

  
  {
    path: '/rezult/:id',
    component: './rezult/[id]',
  },
  
  {
    path: '/create/create_raschet',
    component: './create/create_raschet',
  },
  
  {
    path: '/edit_raschet/:id',
    component: './edit_raschet/[id]',
  },
  



],

  npmClient: 'npm',
});