import { NgModule } from '@angular/core';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';
import { AuditLoggingModule } from '@volo/abp.ng.audit-logging';
import { PageModule } from '@abp/ng.components/page';
import { SaasModule } from '@volo/abp.ng.saas';
import { SharedModule } from '../shared/shared.module';
import { DateRangePickerModule } from '@volo/abp.commercial.ng.ui';
import { PermissionDirective } from '@abp/ng.core';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [],
  imports: [
    SharedModule,
    NgbDatepickerModule,
    SaasModule,
    PageModule,
    DateRangePickerModule,
    PermissionDirective,
    ReactiveFormsModule,
  ],
})
export class PgMemberModule {}
