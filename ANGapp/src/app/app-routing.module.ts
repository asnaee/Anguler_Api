import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewComponent } from './COMPONENT/view/view.component';
import { CreateComponent } from './COMPONENT/create/create.component';

const routes: Routes = [
  {path:'VI',component:ViewComponent},
  {path:'CR',component:CreateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
