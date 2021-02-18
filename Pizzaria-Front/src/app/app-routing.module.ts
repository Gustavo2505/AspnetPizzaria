import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarpratosComponent } from './cadastrarpratos/cadastrarpratos.component';
import { CadastrrestaurantesComponent } from './cadastrrestaurantes/cadastrrestaurantes.component';
import { InicioComponent } from './inicio/inicio.component';
import { PratosComponent } from './pratos/pratos.component';
import { RestaurantesComponent } from './restaurantes/restaurantes.component';

const routes: Routes = [
  {path: 'restaurantes', component: RestaurantesComponent, },
  {path: 'pratos', component: PratosComponent},
  {path: 'inicio', component: InicioComponent},
  {path: 'cadastroPratos', component: CadastrarpratosComponent},
  {path: 'cadastroRestaurantes', component: CadastrrestaurantesComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
