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
    public class QuizsController : ApiController
    {
        private quizapiContext db = new quizapiContext();

        // GET: api/Quizs
        public IQueryable<Quiz> GetQuizs()
        {
            return db.Quizs;
        }

        // GET: api/Quizs/5
        [ResponseType(typeof(Quiz))]
        public IHttpActionResult GetQuiz(string id)
        {
            Quiz quiz = db.Quizs.Find(id);
            if (quiz == null)
            {
                return NotFound();
            }

            return Ok(quiz);
        }

        // PUT: api/Quizs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuiz(string id, Quiz quiz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quiz.IdQuiz)
            {
                return BadRequest();
            }

            db.Entry(quiz).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizExists(id))
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

        // POST: api/Quizs
        [ResponseType(typeof(Quiz))]
        public IHttpActionResult PostQuiz(Quiz quiz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Quizs.Add(quiz);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (QuizExists(quiz.IdQuiz))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = quiz.IdQuiz }, quiz);
        }

        // DELETE: api/Quizs/5
        [ResponseType(typeof(Quiz))]
        public IHttpActionResult DeleteQuiz(string id)
        {
            Quiz quiz = db.Quizs.Find(id);
            if (quiz == null)
            {
                return NotFound();
            }

            db.Quizs.Remove(quiz);
            db.SaveChanges();

            return Ok(quiz);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuizExists(string id)
        {
            return db.Quizs.Count(e => e.IdQuiz == id) > 0;
        }
    }
}