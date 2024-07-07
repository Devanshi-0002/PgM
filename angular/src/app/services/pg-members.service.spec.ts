import { TestBed } from '@angular/core/testing';

import { PgMembersService } from './pg-members.service';

describe('PgMembersService', () => {
  let service: PgMembersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PgMembersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
