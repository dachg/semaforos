import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './material-module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login_component/login.component';
import { ManagerComponentComponent } from './manager_component/manager-component.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { LoginService } from './services/login-service.service';
import { HttpClientModule } from '@angular/common/http';
import { ColorLigthService } from './services/color-ligth.service';
import { TrafficService } from './services/traffic.service';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ManagerComponentComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent },
      { path: 'server', component: ManagerComponentComponent}
    ]),
    FormsModule,
    HttpClientModule,
  ],
  providers: [LoginService, ColorLigthService, TrafficService],
  bootstrap: [AppComponent]
})
export class AppModule { }
