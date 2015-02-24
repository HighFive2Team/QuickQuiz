using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using QuickQuiz.Domain;
using quizapi.Models;

namespace quizapi.Controllers
{
    public class PollsController : ApiController
    {
        private quizapiContext db = new quizapiContext();

        // GET: api/Polls
        public IQueryable<Poll> GetPolls()
        {
            return db.Polls;
        }

        // GET: api/Polls/5
        [ResponseType(typeof(Poll))]
        public IHttpActionResult GetPoll(string id)
        {
            Poll poll = db.Polls.Find(id);
            if (poll == null)
            {
                return NotFound();
            }

            return Ok(poll);
        }

        // PUT: api/Polls/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPoll(string id, Poll poll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != poll.PollId)
            {
                return BadRequest();
            }

            db.Entry(poll).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PollExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Polls
        [ResponseType(typeof(Poll))]
        public IHttpActionResult PostPoll(Poll poll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Polls.Add(poll);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PollExists(poll.PollId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = poll.PollId }, poll);
        }

        // DELETE: api/Polls/5
        [ResponseType(typeof(Poll))]
        public IHttpActionResult DeletePoll(string id)
        {
            Poll poll = db.Polls.Find(id);
            if (poll == null)
            {
                return NotFound();
            }

            db.Polls.Remove(poll);
            db.SaveChanges();

            return Ok(poll);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PollExists(string id)
        {
            return db.Polls.Count(e => e.PollId == id) > 0;
        }
    }
}