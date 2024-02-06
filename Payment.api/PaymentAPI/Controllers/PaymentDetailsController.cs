using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetail>>> GetPayments()
        {
            if (_context.Payments == null) { return NotFound(); }
            return await _context.Payments.ToListAsync();
        }

        // GET: api/Payments/id
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetail>> GetPaymentDetail(int id)
        {
            if (_context.Payments == null) { return NotFound(); }

            var paymentDetail = await _context.Payments.FindAsync(id);

            if (paymentDetail == null) { return NotFound(); }

            return paymentDetail;
        }

        // PUT: api/Payments/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetail(int id, PaymentDetail paymentDetail)
        {
            if (id != paymentDetail.PaymentDetailId) { return BadRequest(); }

            _context.Entry(paymentDetail).State = EntityState.Modified;

            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailExists(id)) { return NotFound(); }
                else { throw; }
            }
            return Ok(await _context.Payments.ToListAsync());
        }

        // POST: api/Payments
        [HttpPost]
        public async Task<ActionResult<PaymentDetail>> PostPaymentDetail(PaymentDetail paymentDetail)
        {
            if (_context.Payments == null) { return Problem("Entity set 'PaymentDetailContext.Payments'  is null."); }
            _context.Payments.Add(paymentDetail);
            await _context.SaveChangesAsync();

            return Ok(await _context.Payments.ToListAsync());
        }

        // DELETE: api/Payments/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetail(int id)
        {
            if (_context.Payments == null) { return NotFound(); }

            var paymentDetail = await _context.Payments.FindAsync(id);

            if (paymentDetail == null) { return NotFound(); }

            _context.Payments.Remove(paymentDetail);
            await _context.SaveChangesAsync();

            return Ok(await _context.Payments.ToListAsync());
        }

        private bool PaymentDetailExists(int id)
        {
            return (_context.Payments?.Any(e => e.PaymentDetailId == id)).GetValueOrDefault();
        }
    }
}
