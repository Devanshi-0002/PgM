import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'CityHome.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'CityHome.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
