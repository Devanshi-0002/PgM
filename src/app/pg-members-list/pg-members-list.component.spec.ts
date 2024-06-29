import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PgMembersListComponent } from './pg-members-list.component';

describe('PgMembersListComponent', () => {
  let component: PgMembersListComponent;
  let fixture: ComponentFixture<PgMembersListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PgMembersListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PgMembersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
